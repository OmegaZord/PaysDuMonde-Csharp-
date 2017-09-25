using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace OperationComboBox
{
    public partial class OpeComboBox : Form
    {
        /**********************************
            Champs / Propriétés / Enums
         **********************************/
        #region Fields

        enum SwitchBox
        {
            Left,
            FullLeft,
            Right,
            FullRight,
        }
        enum MoveList
        {
            Up,
            Down,
            Top,
            Bottom,
        }

        private ErrorProvider _err = new ErrorProvider();
        private List<string> _listException = new List<string>();

        public List<string> ListException
        {
            get { return _listException; }
            set { _listException = value; }
        }

        public ErrorProvider Err
        {
            get { return _err; }
            set { _err = value; }
        }

        #endregion

        /*******************************
                Constructeurs
         *******************************/

        #region Ctor

        public OpeComboBox()
        {
            InitializeComponent();
        }

        #endregion

        /*******************************
                Evènements
         *******************************/
        #region Events

        private void OpeComboBox_Load(object sender, EventArgs e)
        {

            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                try
                {
                    RegionInfo ri = new RegionInfo(ci.LCID);
                    if (!lbCultures.Items.Contains(ri.DisplayName) && saisieValide(ri.DisplayName))
                        lbCultures.Items.Add(ri.DisplayName);
                }
                catch (Exception ex)
                {
                    ListException.Add(ex.Message);
                }
            }
            //foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            //{
            //    if (!lbCultures.Items.Contains(ci.DisplayName))
            //        lbCultures.Items.Add(ci.DisplayName);
            //}
            //saveFileExceptions();
            activateButtons();
        }

        private void cbCultures_SelectedIndexChanged(object sender, EventArgs e)
        {
            activateButtons();
        }

        private void lbCultures_SelectedIndexChanged(object sender, EventArgs e)
        {
            activateButtons();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            switchList(SwitchBox.Right);
            activateButtons();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            switchList(SwitchBox.Left);
            activateButtons();
        }

        private void btnFullRight_Click(object sender, EventArgs e)
        {
            switchList(SwitchBox.FullRight);
            activateButtons();
        }

        private void btnFullLeft_Click(object sender, EventArgs e)
        {
            switchList(SwitchBox.FullLeft);
            activateButtons();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            moveInList(MoveList.Up);
            activateButtons();
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            moveInList(MoveList.Down);
            activateButtons();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            moveInList(MoveList.Top);
            activateButtons();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            moveInList(MoveList.Bottom);
            activateButtons();
        }

        private void cbCultures_TextChanged(object sender, EventArgs e)
        {
            Err.Clear();
        }

        private void cbCultures_KeyDown(object sender, KeyEventArgs e)
        {
            Err.Clear();
            saisirCulture(e);
        }

        private void OpeComboBox_Click(object sender, EventArgs e)
        {
            lbCultures.SelectedIndex = -1;
        }

        #endregion

        /*******************************
                Méthodes
         *******************************/
        #region Methods

        private void moveInList(MoveList d)
        {
            Err.Clear();
            switch (d)
            {
                case MoveList.Up:
                    if (lbCultures.SelectedIndex > 0)
                    {
                        int index = lbCultures.SelectedIndex;
                        lbCultures.Items.Insert(lbCultures.SelectedIndex - 1, lbCultures.Items[lbCultures.SelectedIndex]);
                        lbCultures.Items.RemoveAt(lbCultures.SelectedIndex);
                        lbCultures.SelectedIndex = index - 1;
                    }
                    else if (lbCultures.SelectedIndex == 0)
                    {
                        initializeError(Err, cbCultures, SystemIcons.Warning);
                        Err.SetError(lbCultures, "Vous ne pouvez pas aller plus haut, vous êtes déjà en haut de la liste.");
                    }
                    break;
                case MoveList.Down:
                    if (lbCultures.SelectedIndex < lbCultures.Items.Count - 1)
                    {
                        int index = lbCultures.SelectedIndex;
                        lbCultures.Items.Insert(lbCultures.SelectedIndex + 2, lbCultures.Items[lbCultures.SelectedIndex]);
                        lbCultures.Items.RemoveAt(lbCultures.SelectedIndex);
                        lbCultures.SelectedIndex = index + 1;
                    }
                    else if (lbCultures.SelectedIndex == lbCultures.Items.Count - 1)
                    {
                        initializeError(Err, cbCultures, SystemIcons.Warning);
                        Err.SetError(lbCultures, "Vous ne pouvez pas aller plus bas, vous êtes déjà au fond de la liste.");
                    }
                    break;
                case MoveList.Top:
                    lbCultures.Items.Insert(0, lbCultures.Items[lbCultures.SelectedIndex]);
                    lbCultures.Items.RemoveAt(lbCultures.SelectedIndex);
                    lbCultures.SelectedIndex = 0;
                    break;
                case MoveList.Bottom:
                    lbCultures.Items.Insert(lbCultures.Items.Count, lbCultures.Items[lbCultures.SelectedIndex]);
                    lbCultures.Items.RemoveAt(lbCultures.SelectedIndex);
                    lbCultures.SelectedIndex = lbCultures.Items.Count - 1;
                    break;
                default:
                    break;
            }

        }

        private void switchList(SwitchBox d)
        {
            switch (d)
            {
                case SwitchBox.Left:
                    int index = lbCultures.SelectedIndex;
                    cbCultures.Items.Add(lbCultures.Items[lbCultures.SelectedIndex]);
                    lbCultures.Items.RemoveAt(lbCultures.SelectedIndex);
                    if (index >= lbCultures.Items.Count)
                        lbCultures.SelectedIndex = lbCultures.Items.Count - 1;
                    else
                        lbCultures.SelectedIndex = index;
                    break;
                case SwitchBox.FullLeft:
                    for (int i = 0; i < lbCultures.Items.Count; i++)
                    {
                        cbCultures.Items.Add(lbCultures.Items[i]);
                    }
                    lbCultures.Items.Clear();
                    break;
                case SwitchBox.Right:
                    lbCultures.Items.Add(cbCultures.Items[cbCultures.SelectedIndex]);
                    cbCultures.Items.RemoveAt(cbCultures.SelectedIndex);
                    cbCultures.Text = string.Empty;
                    break;
                case SwitchBox.FullRight:
                    for (int i = 0; i < cbCultures.Items.Count; i++)
                    {
                        lbCultures.Items.Add(cbCultures.Items[i]);
                    }
                    cbCultures.Items.Clear();
                    cbCultures.Text = string.Empty;
                    break;
                default:
                    break;
            }
        }

        private void saisirCulture(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!saisieValide(cbCultures.Text))
                {
                    initializeError(Err, cbCultures, SystemIcons.Error);
                    Err.SetError(cbCultures, "Vous ne pouvez saisir que des caractères alphabétique séparables par un tiret (la saisie ne doit pas commencer par le tiret).");
                }
                else
                {
                    string culture = string.Empty;

                    if (cbCultures.Text != string.Empty)
                        culture = string.Format("{0}{1}", cbCultures.Text.Substring(0, 1).ToUpper(), cbCultures.Text.Substring(1, cbCultures.Text.Length - 1).ToLower());

                    if (!lbCultures.Items.Contains(culture) && !cbCultures.Items.Contains(culture) && cbCultures.Text != string.Empty)
                    {
                        cbCultures.Items.Add(culture);
                        cbCultures.Text = string.Empty;
                        cbCultures.Focus();
                        activateButtons();
                    }
                    else if (cbCultures.Text == string.Empty)
                    {
                        initializeError(Err, cbCultures, SystemIcons.Warning);
                        Err.SetError(cbCultures, "Impossible d'ajouter une entrée vide.");
                    }
                    else
                    {
                        initializeError(Err, cbCultures, SystemIcons.Information);
                        Err.SetError(cbCultures, "La saisie existe déjà dans une des listes.");
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                cbCultures.Text = string.Empty;
            }
        }

        /// <summary>
        /// Initialise un composant ErrorProvider avec le choix de l'icone
        /// </summary>
        /// <param name="err">Le composant ErrorProvider à initialiser</param>
        /// <param name="ctrl">Le controle sur lequel faire apparaitre l'erreur</param>
        /// <param name="icon">L'icone à afficher</param>
        private void initializeError(ErrorProvider err, Control ctrl, Icon icon)
        {
            err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight);
            err.SetIconPadding(ctrl, 2);
            err.Icon = icon;
            err.BlinkRate = 250;
            err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }

        /// <summary>
        /// Activation ou Désactivation des boutons en fonction : de la selection, de listes vides ou non
        /// </summary>
        private void activateButtons()
        {
            /**********************************************************************
             * Enable ou Disable les boutons qui vont de la gauche vers la droite *
             **********************************************************************/
            if (cbCultures.Items.Count == 0 && cbCultures.SelectedItem == null)
            {
                btnRight.Enabled = false;
                btnFullRight.Enabled = false;
            }
            else if (cbCultures.Items.Count > 0 && cbCultures.SelectedItem == null)
            {
                btnRight.Enabled = false;
                btnFullRight.Enabled = true;
            }
            else
            {
                btnRight.Enabled = true;
                btnFullRight.Enabled = true;
            }

            /**********************************************************************
             * Enable ou Disable les boutons qui vont de la droite vers la gauche *
             **********************************************************************/

            if (lbCultures.Items.Count == 0 && lbCultures.SelectedItem == null)
            {
                btnLeft.Enabled = false;
                btnFullLeft.Enabled = false;
                btnMore.Enabled = false;
                btnLess.Enabled = false;
                btnTop.Enabled = false;
                btnBottom.Enabled = false;
            }
            else if (lbCultures.Items.Count > 0 && lbCultures.SelectedItem == null)
            {
                btnLeft.Enabled = false;
                btnFullLeft.Enabled = true;
                btnMore.Enabled = false;
                btnLess.Enabled = false;
                btnTop.Enabled = false;
                btnBottom.Enabled = false;
            }
            else
            {
                btnLeft.Enabled = true;
                btnFullLeft.Enabled = true;
                if (lbCultures.Items.Count > 1) // Si la liste comporte plus d'une entrée, on autorise 
                {
                    btnMore.Enabled = true;
                    btnLess.Enabled = true;
                    btnTop.Enabled = true;
                    btnBottom.Enabled = true;
                }
                else
                {
                    btnMore.Enabled = false;
                    btnLess.Enabled = false;
                    btnTop.Enabled = false;
                    btnBottom.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool saisieValide(string s)
        {
            if (s.Substring(0, 1).Equals("-"))
            {
                return false;
            }

            foreach (char c in s)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '-')
                    return false;
            }
            return true;
        }

        private void saveFileExceptions()
        {
            StreamWriter sw = new StreamWriter("./ListException.txt", true, Encoding.UTF8);
            for (int i = 0; i < ListException.Count; i++)
            {
                sw.WriteLine(string.Format("{0} : {1}", DateTime.Now, ListException[i]));
            }
            sw.Close();
        }

        #endregion
    }
}

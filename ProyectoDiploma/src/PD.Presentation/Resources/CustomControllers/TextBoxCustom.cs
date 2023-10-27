using System.ComponentModel;

namespace PD.Presentation.Resources.CustomControllers
{
    /// <summary>
    /// Ref: https://github.com/RJCodeAdvance/Custom-TextBox-2--Rounded-Placeholder/blob/main/RJTextBox.cs
    /// </summary>

    [DefaultEvent("_TextChanged")]
    public partial class TextBoxCustom : UserControl
    {
        #region Fields

        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        public event EventHandler _TextChanged;

        #endregion Fields

        public TextBoxCustom()
        {
            InitializeComponent();
        }

        #region Properties

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                if (!isPlaceholder)
                    txt.UseSystemPasswordChar = value;
            }
        }

        [Category("RJ Code Advance")]
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                txt.Text = "";
                SetPlaceholder();
            }
        }

        [Category("RJ Code Advance")]
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    txt.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return txt.Text;
            }
            set
            {
                txt.Text = value;
                SetPlaceholder();
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                txt.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                txt.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                txt.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return txt.Multiline; }
            set { txt.Multiline = value; }
        }

        #endregion Properties

        #region Overrider Methods

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        #endregion Overrider Methods

        #region Private Methods

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txt.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                txt.Text = placeholderText;
                txt.ForeColor = placeholderColor;
                if (isPasswordChar)
                    txt.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                txt.Text = "";
                txt.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    txt.UseSystemPasswordChar = true;
            }
        }

        private void UpdateControlHeight()
        {
            if (txt.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txt.Multiline = true;
                txt.MinimumSize = new Size(0, txtHeight);
                txt.Multiline = false;

                this.Height = txt.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #endregion Private Methods

        #region Events

        private void txt_OnClick(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void txt_OnMouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void txt_OnMouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void txt_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txt_OnLeave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void txt_OnEnter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void txt_OnTextChanged(object? sender, EventArgs e)
        {
            //if (_TextChanged != null) 
                _TextChanged.Invoke(sender, e);
        }

        #endregion Events
    }
}
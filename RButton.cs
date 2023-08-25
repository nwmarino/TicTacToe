namespace TicTacToe
{
    public class RButton : Button
    {
        private Color _onHoverButtonColor;
        private Color _onHoverBorderColor;
        private Color _buttonColor;
        private Color _borderColor;
        private Color _textColor;
        private bool _hovering;
        private readonly int _borderThickness = 6;
        private readonly int _borderThicknessByTwo = 3;

        public Color onHoverButtonColor
        {
            get { return _onHoverButtonColor; }
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color onHoverBorderColor
        {
            get { return _onHoverBorderColor; }
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color buttonColor
        {
            get { return _buttonColor; }
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color borderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        public Color textColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public bool hovering
        {
            get { return _hovering; }
            set
            {
                _hovering = value;
                Invalidate();
            }
        }

        public RButton()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                hovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                hovering = false;
                Invalidate();
            };
        }

        protected override void OnPaint (PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_hovering ? _onHoverBorderColor : _borderColor);

            g.FillEllipse(brush, 0, 0, Height, Height);
            g.FillEllipse(brush, Width - Height, 0, Height, Height);
            g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            brush.Dispose();
            brush = new SolidBrush(_hovering ? _onHoverButtonColor : _buttonColor);

            g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
               Height - _borderThickness);
            g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
                Height - _borderThickness, Height - _borderThickness);
            g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
                Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            brush = new SolidBrush(_textColor);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
        }
            
    }
}
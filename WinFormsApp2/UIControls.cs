using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FormTradeRequest
{
    /// <summary>
    /// Custom panel with smooth anti-aliased rounded corners and optional border.
    /// Used for modern pill input containers and user cards.
    /// </summary>
    public class RoundedPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 14;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor { get; set; } = Color.Transparent;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float BorderWidth { get; set; } = 1f;

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = CreateRoundedRectanglePath(rect, CornerRadius))
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (BorderColor != Color.Transparent && BorderWidth > 0)
                {
                    using (var pen = new Pen(BorderColor, BorderWidth))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        public static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            int diameter = radius * 2;
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            var arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            // Top-left
            path.AddArc(arc, 180, 90);
            // Top-right
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            // Bottom-right
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            // Bottom-left
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }

    /// <summary>
    /// Custom button with anti-aliased rounded corners, smooth hover effects, and hand cursor.
    /// </summary>
    public class RoundedButton : Button
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius { get; set; } = 12;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NormalColor { get; set; } = Color.FromArgb(96, 142, 108);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color HoverColor { get; set; } = Color.FromArgb(112, 160, 124);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PressedColor { get; set; } = Color.FromArgb(82, 125, 93);

        private bool isHovered = false;
        private bool isPressed = false;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (mevent.Button == MouseButtons.Left)
            {
                isPressed = true;
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            isPressed = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color currentBg = NormalColor;
            if (isPressed) currentBg = PressedColor;
            else if (isHovered) currentBg = HoverColor;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundedPanel.CreateRoundedRectanglePath(rect, CornerRadius))
            {
                using (var brush = new SolidBrush(currentBg))
                {
                    pevent.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(
                pevent.Graphics,
                Text,
                Font,
                new Rectangle(0, 0, Width, Height),
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }

    /// <summary>
    /// Avatar control that paints a circular silhouette matching the target user card design.
    /// </summary>
    public class AvatarCircle : Control
    {
        public AvatarCircle()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Size = new Size(48, 48);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Background circle (Dark Charcoal / Black)
            using (var brush = new SolidBrush(Color.FromArgb(10, 16, 12)))
            {
                e.Graphics.FillEllipse(brush, 1, 1, Width - 3, Height - 3);
            }

            // Outline ring
            using (var pen = new Pen(Color.FromArgb(48, 72, 54), 1.5f))
            {
                e.Graphics.DrawEllipse(pen, 1, 1, Width - 3, Height - 3);
            }

            // White user silhouette (head and shoulders)
            int cx = Width / 2;
            int cy = Height / 2;
            int headRadius = (int)(Width * 0.19f);

            using (var whiteBrush = new SolidBrush(Color.White))
            {
                // Head
                e.Graphics.FillEllipse(whiteBrush, cx - headRadius, (int)(Height * 0.20f), headRadius * 2, headRadius * 2);

                // Shoulders / Torso clipped to circle
                using (var clipPath = new GraphicsPath())
                {
                    clipPath.AddEllipse(2, 2, Width - 5, Height - 5);
                    e.Graphics.SetClip(clipPath);

                    int bodyWidth = (int)(Width * 0.70f);
                    int bodyHeight = (int)(Height * 0.48f);
                    e.Graphics.FillEllipse(whiteBrush, cx - bodyWidth / 2, (int)(Height * 0.58f), bodyWidth, bodyHeight);

                    e.Graphics.ResetClip();
                }
            }
        }
    }

    /// <summary>
    /// Helper for setting native Windows Cue Banners (gray placeholder text) on textboxes and comboboxes.
    /// </summary>
    public static class CueBannerHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
        private const int EM_SETCUEBANNER = 0x1501;
        private const int CB_SETCUEBANNER = 0x1703;

        public static void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox == null || string.IsNullOrEmpty(placeholder)) return;

            if (textBox.IsHandleCreated)
            {
                SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, placeholder);
            }
            else
            {
                textBox.HandleCreated += (s, e) =>
                {
                    SendMessage(textBox.Handle, EM_SETCUEBANNER, (IntPtr)1, placeholder);
                };
            }
        }

        public static void SetPlaceholder(ComboBox comboBox, string placeholder)
        {
            if (comboBox == null || string.IsNullOrEmpty(placeholder)) return;

            if (comboBox.IsHandleCreated)
            {
                SendMessage(comboBox.Handle, CB_SETCUEBANNER, IntPtr.Zero, placeholder);
            }
            else
            {
                comboBox.HandleCreated += (s, e) =>
                {
                    SendMessage(comboBox.Handle, CB_SETCUEBANNER, IntPtr.Zero, placeholder);
                };
            }
        }

        public static void SetPlaceholder(Control control, string placeholder)
        {
            if (control is TextBox tb) SetPlaceholder(tb, placeholder);
            else if (control is ComboBox cb) SetPlaceholder(cb, placeholder);
        }
    }
}

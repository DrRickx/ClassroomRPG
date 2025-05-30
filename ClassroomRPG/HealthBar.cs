using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class HealthBar : Control
{
    private int maxHealth = 100;
    private int currentHealth = 100;

    [Category("Health")]
    public int MaxHealth
    {
        get => maxHealth;
        set
        {
            if (value <= 0) throw new ArgumentOutOfRangeException("MaxHealth must be > 0");
            maxHealth = value;
            if (currentHealth > maxHealth) currentHealth = maxHealth;
            Invalidate();
        }
    }

    [Category("Health")]
    public int CurrentHealth
    {
        get => currentHealth;
        set
        {
            if (value < 0) value = 0;
            if (value > maxHealth) value = maxHealth;
            currentHealth = value;
            Invalidate();
        }
    }

    public HealthBar()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.ResizeRedraw
            | ControlStyles.UserPaint, true);

        Height = 25;
        Width = 200;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;

        int padding = 2;
        Rectangle borderRect = new Rectangle(0, 0, Width - 1, Height - 1);

        float healthPercent = (float)currentHealth / maxHealth;

        // Calculate bar width based on current health
        int barWidth = (int)((Width - 2 * padding) * healthPercent);

        // Calculate color from green (full health) to red (low health)
        // Linear interpolation of RGB channels
        Color barColor = InterpolateColor(Color.Red, Color.LimeGreen, healthPercent);

        // Draw background bar (gray)
        using (SolidBrush backBrush = new SolidBrush(Color.DarkGray))
        {
            g.FillRectangle(backBrush, borderRect);
        }

        // Draw health bar
        Rectangle healthRect = new Rectangle(padding, padding, barWidth, Height - 2 * padding);
        using (SolidBrush healthBrush = new SolidBrush(barColor))
        {
            g.FillRectangle(healthBrush, healthRect);
        }

        // Draw border
        using (Pen borderPen = new Pen(Color.Black, 2))
        {
            g.DrawRectangle(borderPen, borderRect);
        }

        // Draw health text centered
        string healthText = $"{currentHealth} / {maxHealth}";
        using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
        using (Brush textBrush = new SolidBrush(Color.Black))
        {
            SizeF textSize = g.MeasureString(healthText, font);
            PointF textPos = new PointF(
                (Width - textSize.Width) / 2,
                (Height - textSize.Height) / 2);
            g.DrawString(healthText, font, textBrush, textPos);
        }
    }

    private Color InterpolateColor(Color color1, Color color2, float fraction)
    {
        fraction = Math.Min(1f, Math.Max(0f, fraction));
        int r = (int)(color1.R + (color2.R - color1.R) * fraction);
        int g = (int)(color1.G + (color2.G - color1.G) * fraction);
        int b = (int)(color1.B + (color2.B - color1.B) * fraction);
        return Color.FromArgb(r, g, b);
    }
}

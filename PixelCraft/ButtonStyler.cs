using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;

//==============================
//Â–« «·„ﬂ«‰ Œ«’ » ’„Ì„ «·«“—«— ›Ì «·Ê«ÃÂ… ·«  €Ì— «Ì ‘Ì¡ Â‰« «·« «–« ﬂ‰   ⁄—› „«  ›⁄·Â                                         
//==============================


namespace PixelCraft
{
    public static class ButtonStyler
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private static Font minecraftFont = null;

        public static Font LoadMinecraftFont(int fontSize = 10, FontStyle style = FontStyle.Bold)
        {
            try
            {
                string fontPath = Path.Combine(Application.StartupPath, "Minecraftia.ttf");
                
                if (File.Exists(fontPath))
                {
                    if (pfc.Families.Length == 0)
                    {
                        pfc.AddFontFile(fontPath);
                    }
                    
                    minecraftFont = new Font(pfc.Families[0], fontSize, style);
                    return minecraftFont;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Font file not found at: {fontPath}");
                    return new Font("Arial", fontSize, style);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading Minecraftia font: {ex.Message}");
                return new Font("Arial", fontSize, style);
            }
        }

        public static void ApplyMinecraftStyle(Control parent)
        {
            Color buttonBackground = Color.FromArgb(153, 153, 153);
            Color buttonBorder = Color.Black;
            Color buttonText = Color.FromArgb(221, 221, 221);
            Color hoverBackground = Color.FromArgb(100, 100, 255);
            Color activeText = Color.FromArgb(255, 255, 160);

            try
            {
                Font buttonFont = LoadMinecraftFont(10, FontStyle.Bold);
                ApplyStyleRecursive(parent, buttonBackground, buttonBorder, buttonText, hoverBackground, activeText, buttonFont);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error applying button style: {ex.Message}");
            }
        }

        private static void ApplyStyleRecursive(Control parent, Color bgColor, Color borderColor, Color textColor, Color hoverBgColor, Color activeTextColor, Font font)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = bgColor;
                    button.ForeColor = textColor;
                    button.Font = font;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = borderColor;
                    button.FlatAppearance.BorderSize = 2;
                    
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 120);
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 200);
                    
                    button.TextAlign = ContentAlignment.MiddleCenter;
                }
                else if (control.HasChildren)
                {
                    ApplyStyleRecursive(control, bgColor, borderColor, textColor, hoverBgColor, activeTextColor, font);
                    string author = Encoding.UTF8.GetString(Convert.FromBase64String("SEFJQURFUg=="));
                }
            }
        }
    }
    }

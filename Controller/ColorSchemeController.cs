using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;

namespace Student_Information_System.Controller
{
    public enum ColorScheme
    {
        Light,
        Night
    }
    internal class ColorSchemeController
    {
        public ColorScheme ColorMode { get; set; } = ColorScheme.Light;
        // Light theme colors
        private static readonly Color lightBackground = ColorTranslator.FromHtml("#e8e5ff");
        private static readonly Color lightForeground = ColorTranslator.FromHtml("#000000");
        private static readonly Color lightCard = ColorTranslator.FromHtml("#dcd8f2");
        private static readonly Color lightCardForeground = ColorTranslator.FromHtml("#18181a");
        private static readonly Color lightPopover = ColorTranslator.FromHtml("#e8e5ff");
        private static readonly Color lightPopoverForeground = ColorTranslator.FromHtml("#000000");
        private static readonly Color lightPrimary = ColorTranslator.FromHtml("#322870");
        private static readonly Color lightPrimaryForeground = ColorTranslator.FromHtml("#ffffff");
        private static readonly Color lightSecondary = ColorTranslator.FromHtml("#a19bc9");
        private static readonly Color lightSecondaryForeground = ColorTranslator.FromHtml("#000000");
        private static readonly Color lightMuted = ColorTranslator.FromHtml("#cdd8e4");
        private static readonly Color lightMutedForeground = ColorTranslator.FromHtml("#55545d");
        private static readonly Color lightAccent = ColorTranslator.FromHtml("#bcccdb");
        private static readonly Color lightAccentForeground = ColorTranslator.FromHtml("#18181a");
        private static readonly Color lightDestructive = ColorTranslator.FromHtml("#990000");
        private static readonly Color lightDestructiveForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color lightBorder = ColorTranslator.FromHtml("#6359a5");
        private static readonly Color lightInput = ColorTranslator.FromHtml("#23203b");
        private static readonly Color lightRing = ColorTranslator.FromHtml("#322870");


        // Dark theme colors
        private static readonly Color darkBackground = ColorTranslator.FromHtml("#100b1c");
        private static readonly Color darkForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color darkCard = ColorTranslator.FromHtml("#262331");
        private static readonly Color darkCardForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color darkPopover = ColorTranslator.FromHtml("#080613");
        private static readonly Color darkPopoverForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color darkPrimary = ColorTranslator.FromHtml("#8c80ae");
        private static readonly Color darkPrimaryForeground = ColorTranslator.FromHtml("#ffffff");
        private static readonly Color darkSecondary = ColorTranslator.FromHtml("#76699e");
        private static readonly Color darkSecondaryForeground = ColorTranslator.FromHtml("#ffffff");
        private static readonly Color darkMuted = ColorTranslator.FromHtml("#1a2631");
        private static readonly Color darkMutedForeground = ColorTranslator.FromHtml("#95939e");
        private static readonly Color darkAccent = ColorTranslator.FromHtml("#1a2631");
        private static readonly Color darkAccentForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color darkDestructive = ColorTranslator.FromHtml("#990000");
        private static readonly Color darkDestructiveForeground = ColorTranslator.FromHtml("#e4e4e6");
        private static readonly Color darkBorder = ColorTranslator.FromHtml("#a298be");
        private static readonly Color darkInput = ColorTranslator.FromHtml("#23203b");
        private static readonly Color darkRing = ColorTranslator.FromHtml("#322870");

        public void ApplyLightTheme(Form form, List<Control> controls)
        {
            form.BackColor = lightBackground;
            form.ForeColor = lightForeground;

            foreach (Control control in controls)
            {
                if (control is BunifuPanel bunifu_panel)
                {
                    bunifu_panel.BackgroundColor = lightCard;
                    bunifu_panel.BorderColor = lightBorder;
                    bunifu_panel.ForeColor = lightCardForeground;
                }
                if (control is Guna2Panel guna2_panel)
                {
                    if (guna2_panel.Name == "pnlTitle")
                    {
                        guna2_panel.FillColor = lightCard;
                        guna2_panel.CustomBorderColor = lightBorder;
                        guna2_panel.ForeColor = lightCardForeground;
                    }
                    else
                    {
                        guna2_panel.FillColor = lightAccent;
                        guna2_panel.BorderColor = lightBorder;
                        guna2_panel.ForeColor = lightAccentForeground;
                    }
                }
                if (control is Guna2Button bunifu_button)
                {
                    bunifu_button.FillColor = lightPrimary;
                    bunifu_button.ForeColor = lightPrimaryForeground;
                    bunifu_button.HoverState.FillColor = lightSecondary;
                }
                if (control is BunifuImageButton bunifu_image_button)
                {
                    bunifu_image_button.BackColor = lightCard;
                }
                if (control is Guna2ControlBox ctrlBox)
                {
                    if (ctrlBox.Name == "ctrlClose")
                    {
                        ctrlBox.IconColor = lightSecondaryForeground;
                        ctrlBox.HoverState.FillColor = lightDestructive;
                        ctrlBox.HoverState.IconColor = lightDestructiveForeground;
                    }
                    else
                    {
                        ctrlBox.IconColor = lightSecondaryForeground;
                        ctrlBox.HoverState.FillColor = lightSecondary;
                        ctrlBox.HoverState.IconColor = lightDestructiveForeground;
                    }
                }
                if (control is BunifuTextBox bunifu_textbox)
                {
                    //Functions Override
                    bunifu_textbox.OnIdleState.FillColor = lightPopover;
                    bunifu_textbox.OnIdleState.BorderColor = lightAccent;
                    bunifu_textbox.OnIdleState.ForeColor = lightPopoverForeground;
                    bunifu_textbox.OnIdleState.PlaceholderForeColor = lightMutedForeground;

                    bunifu_textbox.OnActiveState.FillColor = lightPopover;
                    bunifu_textbox.OnActiveState.BorderColor = lightRing;
                    bunifu_textbox.OnActiveState.ForeColor = lightPopoverForeground;
                    bunifu_textbox.OnActiveState.PlaceholderForeColor = lightMutedForeground;

                    bunifu_textbox.OnHoverState.FillColor = lightPopover;
                    bunifu_textbox.OnHoverState.BorderColor = lightSecondary;
                    bunifu_textbox.OnHoverState.ForeColor = lightPopoverForeground;
                    bunifu_textbox.OnHoverState.PlaceholderForeColor = lightMutedForeground;
                }
                if (control is BunifuDropdown bunifu_cmb)
                {
                    bunifu_cmb.BackgroundColor = lightPopover;
                    bunifu_cmb.ForeColor = lightPopoverForeground;
                    bunifu_cmb.BorderColor = lightAccent;
                    bunifu_cmb.IndicatorColor = lightPrimary;
                    // ITEM
                    bunifu_cmb.ItemBackColor = lightPopover;
                    bunifu_cmb.ItemBorderColor = lightBorder;
                    bunifu_cmb.ItemHighLightColor = lightAccent;
                    bunifu_cmb.ItemHighLightForeColor = lightAccentForeground;
                }
                if (control is BunifuDataGridView bunifu_grid)
                {
                    //HEADER
                    bunifu_grid.BackgroundColor = lightCard;
                    bunifu_grid.GridColor = lightBorder;
                    bunifu_grid.CurrentTheme.GridColor = lightBorder;
                    bunifu_grid.HeaderBackColor = lightCard;
                    bunifu_grid.CurrentTheme.HeaderStyle.SelectionBackColor = lightCard;
                    bunifu_grid.CurrentTheme.HeaderStyle.BackColor = lightCard;
                    bunifu_grid.HeaderForeColor = lightCardForeground;
                    bunifu_grid.CurrentTheme.HeaderStyle.ForeColor = lightCardForeground;
                    //ROWS
                    bunifu_grid.CurrentTheme.RowsStyle.BackColor = lightPopover;
                    bunifu_grid.CurrentTheme.RowsStyle.ForeColor = lightPopoverForeground;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.BackColor = lightCard;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.ForeColor = lightCardForeground;
                    bunifu_grid.CurrentTheme.RowsStyle.SelectionBackColor = lightAccent;
                    bunifu_grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = lightAccent;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = lightAccent;
                }
            }
            ColorMode = ColorScheme.Light;
        }

        public void ApplyDarkTheme(Form form, List<Control> controls)
        {
            form.BackColor = darkBackground;
            form.ForeColor = darkForeground;

            foreach (Control control in controls)
            {
                if (control is BunifuPanel bunifu_panel)
                {
                    bunifu_panel.BackgroundColor = darkCard;
                    bunifu_panel.BorderColor = darkBorder;
                    bunifu_panel.ForeColor = darkCardForeground;
                }
                if (control is Guna2Panel guna2_panel)
                {
                    if (guna2_panel.Name == "pnlTitle")
                    {
                        guna2_panel.FillColor = darkCard;
                        guna2_panel.CustomBorderColor = darkBorder;
                        guna2_panel.ForeColor = darkCardForeground;
                    }
                    else
                    {
                        guna2_panel.FillColor = darkAccent;
                        guna2_panel.BorderColor = darkBorder;
                        guna2_panel.ForeColor = darkAccentForeground;
                    }
                }
                if (control is Guna2Button bunifu_button)
                {
                    bunifu_button.FillColor = darkPrimary;
                    bunifu_button.ForeColor = darkPrimaryForeground;
                    bunifu_button.HoverState.FillColor = darkSecondary;
                }
                if (control is BunifuImageButton bunifu_image_button)
                {
                    bunifu_image_button.BackColor = darkCard;
                }
                if (control is Guna2ControlBox ctrlBox)
                {
                    if (ctrlBox.Name == "ctrlClose")
                    {
                        ctrlBox.IconColor = darkSecondaryForeground;
                        ctrlBox.HoverState.FillColor = darkDestructive;
                        ctrlBox.HoverState.IconColor = darkDestructiveForeground;
                    }
                    else
                    {
                        ctrlBox.IconColor = darkSecondaryForeground;
                        ctrlBox.HoverState.FillColor = darkSecondary;
                        ctrlBox.HoverState.IconColor = darkDestructiveForeground;
                    }
                }
                if (control is BunifuTextBox bunifu_textbox)
                {
                    //Functions Override
                    bunifu_textbox.OnIdleState.FillColor = darkPopover;
                    bunifu_textbox.OnIdleState.BorderColor = darkAccent;
                    bunifu_textbox.OnIdleState.ForeColor = darkPopoverForeground;
                    bunifu_textbox.OnIdleState.PlaceholderForeColor = darkMutedForeground;

                    bunifu_textbox.OnActiveState.FillColor = darkPopover;
                    bunifu_textbox.OnActiveState.BorderColor = darkRing;
                    bunifu_textbox.OnActiveState.ForeColor = darkPopoverForeground;
                    bunifu_textbox.OnActiveState.PlaceholderForeColor = darkMutedForeground;

                    bunifu_textbox.OnHoverState.FillColor = darkPopover;
                    bunifu_textbox.OnHoverState.BorderColor = darkSecondary;
                    bunifu_textbox.OnHoverState.ForeColor = darkPopoverForeground;
                    bunifu_textbox.OnHoverState.PlaceholderForeColor = darkMutedForeground;
                }
                if (control is BunifuDataGridView bunifu_grid)
                {
                    //HEADER
                    bunifu_grid.BackgroundColor = darkCard;
                    bunifu_grid.GridColor = darkBorder;
                    bunifu_grid.CurrentTheme.GridColor = darkBorder;
                    bunifu_grid.HeaderBackColor = darkCard;
                    bunifu_grid.CurrentTheme.HeaderStyle.SelectionBackColor = darkCard;
                    bunifu_grid.CurrentTheme.HeaderStyle.BackColor = darkCard;
                    bunifu_grid.HeaderForeColor = darkCardForeground;
                    bunifu_grid.CurrentTheme.HeaderStyle.ForeColor = darkCardForeground;
                    //ROWS
                    bunifu_grid.CurrentTheme.RowsStyle.BackColor = darkPopover;
                    bunifu_grid.CurrentTheme.RowsStyle.ForeColor = darkPopoverForeground;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.BackColor = darkCard;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.ForeColor = darkCardForeground;
                    bunifu_grid.CurrentTheme.RowsStyle.SelectionBackColor = darkAccent;
                    bunifu_grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = darkAccent;
                    bunifu_grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = darkAccent;
                }
            }
            ColorMode = ColorScheme.Night;
        }
    }
}

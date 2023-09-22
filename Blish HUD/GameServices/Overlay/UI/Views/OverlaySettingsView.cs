﻿using Blish_HUD.Graphics.UI;
using Blish_HUD.Controls;
using Blish_HUD.Settings.UI.Views;

namespace Blish_HUD.Overlay.UI.Views {
    public class OverlaySettingsView : View {

        protected override void Build(Container buildPanel) {
            var rootPanel = new FlowPanel() {
                WidthSizingMode  = SizingMode.Fill,
                HeightSizingMode = SizingMode.Fill,
                FlowDirection    = ControlFlowDirection.SingleTopToBottom,
                CanScroll        = true,
                Parent           = buildPanel
            };

            BuildOverlaySettings(rootPanel);
        }

        private ViewContainer GetStandardPanel(Panel rootPanel, string title) {
            return new ViewContainer() {
                WidthSizingMode  = SizingMode.Fill,
                HeightSizingMode = SizingMode.AutoSize,
                Title            = title,
                ShowBorder       = true,
                Parent           = rootPanel
            };
        }

        private void BuildOverlaySettings(Panel rootPanel) {
            GetStandardPanel(rootPanel, Strings.Common.BlishHUD + " " + Strings.GameServices.OverlayService.OverlaySettingsSection).Show(new SettingsView(GameService.Overlay.OverlaySettings));
            GetStandardPanel(rootPanel, Strings.Common.BlishHUD + " " + Strings.GameServices.OverlayService.OverlayDynamicHUDSection).Show(new SettingsView(GameService.Overlay.DynamicHUDSettings));
            GetStandardPanel(rootPanel, Strings.Common.BlishHUD + " " + Strings.GameServices.GraphicsService.GraphicsSettingsSection).Show(new SettingsView(GameService.Graphics.GraphicsSettings));
            GetStandardPanel(rootPanel, Strings.Common.BlishHUD + " " + Strings.GameServices.DebugService.DebugSettingsSection).Show(new SettingsView(GameService.Debug.DebugSettings));
        }

    }
}

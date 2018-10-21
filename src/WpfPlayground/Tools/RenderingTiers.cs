using System;
using System.Windows;
using System.Windows.Media;

namespace WpfPlayground.Tools
{
    public class RenderingTiers
    {
        private int renderingTier;

        public RenderingTiers()
        {
            this.renderingTier = RenderCapability.Tier >> 16;
        }
        
        public void ShowTier()
        {
            string msg = "";

            switch(this.renderingTier)
            {
                case 0:
                    msg = "No graphics hardware acceleration. All graphics features use software acceleration. The DirectX version level is less than version 9.0.";
                    break;

                case 1:
                    msg = "Some graphics features use graphics hardware acceleration. The DirectX version level is greater than or equal to version 9.0. ";
                    break;

                case 2:
                    msg = "Most graphics features use graphics hardware acceleration. The DirectX version level is greater than or equal to version 9.0. ";
                    break;
            }

            MessageBox.Show($"Tier = {this.renderingTier}{Environment.NewLine}{msg}");
        }
    }
}

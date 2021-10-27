

using System.Text;

namespace RombWithStars
{
    public class RhombusAsStringDrawer
    {
        public string Draw(int sizeOfRomb)
        {
            StringBuilder sb = new StringBuilder();
            this.DrawTopPart(sb, sizeOfRomb);
            this.DrawLineOfStars(sb, sizeOfRomb);
            this.DrawBottomPart(sb, sizeOfRomb);

            return sb.ToString();
        }
        private void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 1; i < n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }
        private void DrawBottomPart(StringBuilder sb, int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }
        }
        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                sb.Append('*');
                if (i < numberOfStars)
                {
                    sb.Append(' ');
                }
            }
            sb.AppendLine();
        }
    }
}

using System;

namespace App3
{
    public partial class QuotesPage
    {
        private readonly string[] quotes = { "yes", "no", "maybe", "never" };
        private int currentQuotesIndex;

        public QuotesPage()
        {
            InitializeComponent();

            currentQuotesIndex = 0;

            UpdateQuote();
        }

        private void UpdateQuote()
        {
            QuoteLabel.Text = quotes[currentQuotesIndex];
        }

        private void NextButton_OnClicked(object sender, EventArgs e)
        {
            currentQuotesIndex++;
            if (currentQuotesIndex >= quotes.Length)
                currentQuotesIndex = 0;

            UpdateQuote();
        }
    }
}

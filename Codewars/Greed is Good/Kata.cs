namespace Codewars.Greed_is_Good
{
    public static class GreedIsGoodKata
    {
        public static int Score(int[] dice)
        {
            var score = 0;

            var oneCount = 0;
            var twoCount = 0;
            var threeCount = 0;
            var fourCount = 0;
            var fiveCount = 0;
            var sixCount = 0;

            for (int i = 0; i < dice.Length; i++)
            {
                switch (dice[i])
                {
                    case 1:
                        oneCount++;
                        if (oneCount == 3)
                        {
                            score += 800;
                        }
                        else
                        {
                            score += 100;
                        }
                        break;
                    case 2:
                        twoCount++;
                        if (twoCount == 3)
                        {
                            score += 200;
                        }
                        break;
                    case 3:
                        threeCount++;
                        if (threeCount == 3)
                        {
                            score += 300;
                        }
                        break;
                    case 4:
                        fourCount++;
                        if (fourCount == 3)
                        {
                            score += 400;
                        }
                        break;
                    case 5:
                        fiveCount++;
                        if (fiveCount == 3)
                        {
                            score += 400;
                        }
                        else
                        {
                            score += 50;
                        }
                        break;
                    case 6:
                        sixCount++;
                        if (sixCount == 3)
                        {
                            score += 600;
                        }
                        break;
                }
            }

            return score;
        }
    }
}

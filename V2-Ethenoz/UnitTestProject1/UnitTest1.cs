using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewSpicyVader;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // --------------------------------------------------------- test class Player --------------------------------------------------------------
        [TestMethod]
        public void TestShootingPlayer()
        {
            // Arrange
            int targetLeft = 106;
            int targetTop = 68;

            // Act
            while (targetTop >= 1)
            {
                targetTop--;
            }

            // Assert
            Assert.AreEqual(106, targetLeft, "Le résultat doit être de 106");
            Assert.AreEqual(0, targetTop, "Le résultat doit être de 0");
        }

        [TestMethod]
        public void TestDeplacementPlayerLeft()
        {
            // Arrange
            int left = 100;
            int targetLeft = 106;

            // Act       
            while (left > 0)
            {
                targetLeft -= 2;
                left -= 2;
            }

            // Assert
            Assert.AreEqual(0, left, "Le résultat doit être de 0");
            Assert.AreEqual(6, targetLeft, "Le résultat doit être de -2");
        }

        [TestMethod]
        public void TestDeplacementPlayerRigth()
        {
            // Arrange
            int left = 100;
            int targetLeft = 106;

            // Act         
            while (left < 220)
            {
                targetLeft += 2;
                left += 2;
            }

            // Assert
            Assert.AreEqual(220, left, "Le résultat doit être de 220");
            Assert.AreEqual(226, targetLeft, "Le résultat doit être de 222");
        }

        // ------------------------------------------------------------------- test class Ennemy ---------------------------------------------------------//
        [TestMethod]
        public void TestDeplacementEnnemy()
        {
            // Arrange
            int sourceLeft = 0;     // point le plus à gauche
            int sourceTop = 0;      // point le plus en haut
            int targetTop = 0;      // position voulue en haut
            int targetLeft = 0;     // position voulue à gauche

            // Act
            if (targetTop != 40)
            {
                // déplacement droite
                if (targetTop % 4 == 0)
                {
                    if (targetLeft < 115)
                    {
                        targetLeft++;
                        sourceLeft++;
                    }
                    else
                    {
                        targetTop += 2;
                        sourceTop += 2;
                    }
                }
                // déplacement gauche
                else
                {
                    if (targetLeft > 2)
                    {
                        targetLeft--;
                        sourceLeft--;
                    }
                    else
                    {
                        targetTop += 2;
                        sourceTop += 2;
                    }
                }

                // Assert
                Assert.IsNotNull(targetTop, "le résultat ne doit pas être null");
                Assert.IsNotNull(sourceTop, "le résultat ne doit pas être null");
                Assert.IsNotNull(targetLeft, "le résultat ne doit pas être null");
                Assert.IsNotNull(sourceLeft, "le résultat ne doit pas être null");
            }
        }
    }
}

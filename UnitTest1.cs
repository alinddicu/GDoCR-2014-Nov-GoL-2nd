using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gol
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Une_Cellule_Vivante_Avec_Moins_De_2_Voisins_Vivants_Meurt()
        {
            var cell = new Cell(true);
            var otherCell1 = new Cell(true);
            cell.AddNeighbour(otherCell1);
            cell.ComputeState();
            Assert.IsFalse(cell.IsAlive());
        }

        [TestMethod]
        public void Une_Cellule_Vivante_Avec_2_Voisins_Vivants_Reste_En_Vie()
        {
            var cell = new Cell(true);
            var otherCell1 = new Cell(true);
            cell.AddNeighbour(otherCell1);
            var otherCell2 = new Cell(true);
            cell.AddNeighbour(otherCell2);
            cell.ComputeState();
            Assert.IsTrue(cell.IsAlive());
        }

        [TestMethod]
        public void Une_Cellule_Morte_Avec_2_Voisins_Vivants_Reste_Morte()
        {
            var cell = new Cell(false);
            var otherCell1 = new Cell(true);
            cell.AddNeighbour(otherCell1);
            var otherCell2 = new Cell(true);
            cell.AddNeighbour(otherCell2);
            cell.ComputeState();
            Assert.IsFalse(cell.IsAlive());
        }

        [TestMethod]
        public void Une_Cellule_Avec_3_Voisins_Vivants_Est_En_Vie()
        {
            var cell = new Cell(false);
            var otherCell1 = new Cell(true);
            cell.AddNeighbour(otherCell1);
            var otherCell2 = new Cell(true);
            cell.AddNeighbour(otherCell2);
            var otherCell3 = new Cell(true);
            cell.AddNeighbour(otherCell3);
            cell.ComputeState();
            Assert.IsTrue(cell.IsAlive());
        }
    }
}

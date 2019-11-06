using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainReservationKataTests
{
    [TestClass]
    public class TicketOfficeMSTests
    {

        // TODO: Écrire la fonctionnalité pour la réservation de siège sur un train particulier
        //   Règles d’affaires:
        //      - Pas plus de 70% des sièges devraient être réservés à l’avance pour le train au complet.
        //      - Idéalement, chaque wagon ne devrait pas avoir plus de 70% des sièges réservés.
        //      - Tous les sièges d’une même réservation devraient être dans le même wagon.
        //          - Cela peut faire passer le pourcentage de sièges réservés pour un wagon à plus de 70%
        //          - Il faut toujours s’assuré que le train ne dépasse pas 70% des sièges réservés.


        [TestMethod]
        public void ReserveSeats()
        {
            //--Arrange
           
            //--Act

            //--Assert
            Assert.IsTrue(true);

        }
    }
}
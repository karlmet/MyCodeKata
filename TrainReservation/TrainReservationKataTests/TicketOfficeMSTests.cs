using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrainReservationKataTests
{
    [TestClass]
    public class TicketOfficeMSTests
    {

        // TODO: �crire la fonctionnalit� pour la r�servation de si�ge sur un train particulier
        //   R�gles d�affaires:
        //      - Pas plus de 70% des si�ges devraient �tre r�serv�s � l�avance pour le train au complet.
        //      - Id�alement, chaque wagon ne devrait pas avoir plus de 70% des si�ges r�serv�s.
        //      - Tous les si�ges d�une m�me r�servation devraient �tre dans le m�me wagon.
        //          - Cela peut faire passer le pourcentage de si�ges r�serv�s pour un wagon � plus de 70%
        //          - Il faut toujours s�assur� que le train ne d�passe pas 70% des si�ges r�serv�s.


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
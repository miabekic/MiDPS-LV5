
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GreenGOSystem {

    public GreenGOSystem() {
    }

    private int numberOfActiveUsers;

    private int totalUserNumber;

    private string localBackupTime = "3 AM";

    private DateTime lastBackup;









    /// <summary>
    /// @return
    /// </summary>
    private void makeLocalBackup() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param itineraries 
    /// @return
    /// </summary>
    public void displayItineraries(List<Itinerary> itineraries) {//in this method we display gotten list of itineraries on the web site
        // TODO implement here
        //defining ListView and its columns
        foreach(Itinerary itinerary in itineraries){
            //creating new ListViewItem and its subitems according to the attributes of Itinerary objekt
            //adding new ListViewItem in ListView
        }
        //display ListView on the web site
    }

    /// <summary>
    /// @param itinerary 
    /// @return
    /// </summary>
    public void colorItinerary(List<Itinerary> itinerary) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param username 
    /// @return
    /// </summary>
    public List<Itinerary> getReservedItineraries(string username) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param itineraries 
    /// @return
    /// </summary>
    public void displayReservedItineraries(List<Itinerary> itineraries) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param itinerary 
    /// @return
    /// </summary>
    public void displayPaymentForm(Itinerary itinerary) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param creditCard 
    /// @param cost 
    /// @param id 
    /// @return
    /// </summary>
    public void sendPaymentRequest(Credit card creditCard, double cost, string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public bool checkAvailabilityOfService(string id) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void makeServiceReservarion(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void displayFormNewItinerary() { //this method displays a form for entering data based on which itineraries will be generated
        // TODO implement here
    }

    /// <summary>
    /// @param itineraries 
    /// @return
    /// </summary>
    public void displayNonFinishedItineraries(List<Itinerary> itineraries) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public List<Itinerary> getNonFinishedItineraries() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void updateFinishedStateOfItinerary(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public void displayHelpdeskChat() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void displayFormForCreatingUpdatingService(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param service 
    /// @return
    /// </summary>
    public void insertOffer(Service service) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void updateOffer(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param services 
    /// @return
    /// </summary>
    public void displayCurrentOffers(List<Service> services) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param username 
    /// @param password 
    /// @return
    /// </summary>
    public bool checkLogingData(string username, string password) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param itinerary 
    /// @return
    /// </summary>
    public double recalculateItineraryPrice(Itinerary itinerary) {
        // TODO implement here
        return 0.0D;
    }

    /// <summary>
    /// @param promoCode 
    /// @return
    /// </summary>
    public bool verifyPromoCode(string promoCode) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param itineraries 
    /// @return
    /// </summary>
    public void displayUsersItineraries(List<Itinerary> itineraries) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public bool checkFinisedStatus(string id) {
        // TODO implement here
        return False;
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void displayFormForAddingReview(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param review 
    /// @return
    /// </summary>
    public void insertReview(Review review) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param username 
    /// @param review 
    /// @return
    /// </summary>
    public void sendNotificationToPOI(string username, Review review) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param review 
    /// @param username 
    /// @return
    /// </summary>
    public void publishReviewOnPOIsProfile(Review review, string username) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param itinerary 
    /// @return
    /// </summary>
    public List<Itinerary> createItineraries(Itinerary itinerary) {
        // TODO implement here
        // Database searching and getting results
        List<Itinerary> itineraries;
        for(int i=0; i<numberOfValueGottenFromDatabase; i++){
            Itinerary itinerary=new Itinerary(dateFrom, dateTo, includedServices, includedPOIs); //listed parameters are obtained
                                                                                                //as data from the database
                                                                                                
            itineraries.Add(itinerary);
        }
        return itineraries;
    }

    /// <summary>
    /// @param username 
    /// @return
    /// </summary>
    public List<Service> getCurrentOffers(string username) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param username 
    /// @return
    /// </summary>
    public List<Itinerary> getUsersItineraries(string username) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param itinerary 
    /// @return
    /// </summary>
    public void generateItinerary(Itinerary itinerary) {//this method is called when user presses the button for generating itineraries;
                                                        //when user presses that button, object Itinerary (that is going to be passed
                                                        //to this method) is created according to the dataentered in the form and
                                                        //then this method is called 
        
        // TODO implement here
        List<Itinerary> itineraries;
        itineraries=createItineraries(itinerary);
        displayItineraries(itineraries);
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public void markItineraryAsFinished(string id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param newUser 
    /// @return
    /// </summary>
    public void registerNewUser(UsersOfSystem newUser) {
        // TODO implement here
        return null;
    }

}
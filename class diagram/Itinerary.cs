
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Itinerary {

    public Itinerary() {
    }
    public Itinerary(DateTime dateFrom, DataTime dateTo, List<Service> includedServices, List<POI> includedPOIs) {
        this.dateFrom=dateFrom;
        this.dateTo=dateTo;
        this.includedServices=includedServices;
        this.includedPOIs=includedPOIs;
    }

    private DateTime dateFrom;

    private DateTime dateTo;

    private List<Service> includedServices;

    private List<POI> includedPOIs;

    private bool finished;

    private List<Review> reviews;

    private double cost;

    private string ID;











    /// <summary>
    /// @param poi 
    /// @return
    /// </summary>
    public void removePOI(POI poi) {
        // TODO implement here
        return null;
    }

}
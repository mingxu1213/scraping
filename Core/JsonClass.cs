﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Store
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postCode { get; set; }
        public int deliveryTimeMinutes { get; set; }
        public int pickupTimeMinutes { get; set; }
        public object kilometersTo { get; set; }
        public bool canPickupNow { get; set; }
        public bool canAcceptOnlineOrders { get; set; }
        public string timeBeforeStoreOpens { get; set; }
        public bool isOpen { get; set; }
        public string telephone { get; set; }
        public string todayPickupHours { get; set; }
        public string todayDeliveryHours { get; set; }
        public string todayDineInHours { get; set; }
        public string tradingStatus { get; set; }
        public object phStoreUrl { get; set; }
        public bool canAcceptOnlineCreditCards { get; set; }
        public bool canAcceptPayPalPayment { get; set; }
        public bool canAcceptOnlineAmexCheckout { get; set; }
        public bool canAcceptOnlineVisaCheckout { get; set; }
        public bool canVirtualDrivethru { get; set; }
        public bool canPickup { get; set; }
        public bool canDeliver { get; set; }
        public double minimumPickupAmount { get; set; }
        public double minimumDeliveryAmount { get; set; }
        public string merchantApiKey { get; set; }
        public string location { get; set; }
        public object timeTable { get; set; }
    }

    public class PResult
    {
        public List<Store> stores { get; set; }
        public List<string> states { get; set; }
    }

    public class PizzaResult
    {
        public bool success { get; set; }
        public PResult result { get; set; }
        public object error { get; set; }
        public bool unAuthorizedRequest { get; set; }
    }

    public class Result
    {
        public double latitude { get; set; }
        public string listingId { get; set; }
        public double longitude { get; set; }
    }

    public class TieredResult
    {
        public int tier { get; set; }
        public int count { get; set; }
        public List<Result> results { get; set; }
    }

    public class RealResult
    {
        public int totalResultsCount { get; set; }
        public List<TieredResult> tieredResults { get; set; }
    }
}

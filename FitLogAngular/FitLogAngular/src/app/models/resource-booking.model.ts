import { Booking } from "app/models/booking.model";
import { Resource } from "app/models/resource.model";

export class ResourceBooking {
    booking: Booking = new Booking;
    resource: Resource;
    amount: number;
}
import {Component, OnInit} from '@angular/core';
import {BookingHttpService} from "../data-service/all_bookings/all_booking-service.component";
import {Booking} from "../models/booking.model";
import {Contact} from "../models/contact.model";
import {isBoolean} from "util";

@Component({
  selector: 'app-registrations',
  templateUrl: './registrations.component.html',
  styleUrls: ['./registrations.component.css']
})
export class RegistrationsComponent implements OnInit{
  private bookings: Booking[];
  constructor(private httpService : BookingHttpService){

  }

  ngOnInit(){
   this.getBookings();
  }

  deleteBooking(bookingId:number){
      alert("Wirklich löschen?");
      this.httpService.deleteBooking(bookingId).subscribe(() => this.getBookings());
    }

  getBookings(){
    this.httpService.getAllRegistrations().subscribe(res => this.bookings = res);
  }




}

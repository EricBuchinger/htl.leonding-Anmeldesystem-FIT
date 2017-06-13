import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Params, Router, RouterLinkActive} from "@angular/router";
import {BookingHttpService} from "../../data-service/all_bookings/all_booking-service.component";
import {Booking} from "../../models/booking.model";

@Component({
  selector: 'app-edit-registration',
  templateUrl: './edit-registration.component.html',
  styleUrls: ['./edit-registration.component.css']
})
export class EditRegistrationComponent implements OnInit {

  booking:Booking = null;
  helpBooking:Booking;
  firmenname:string;
  standplatz:number;

  constructor(private activeRoute:ActivatedRoute,private httpService:BookingHttpService,private router:Router) {

  }

  ngOnInit() {
    this.activeRoute.params.subscribe((params:Params) => this.httpService.getBookingById(params['id']).subscribe(res => {
      this.booking = res;
      this.helpBooking = res;
      this.firmenname = res.company.name;
      this.standplatz = res.location.number;
    }));
  }
  cancelEdit(){
    this.booking = this.helpBooking;
    this.router.navigate(['registrations']);
  }
  saveBooking(){
    this.httpService.updateBooking(this.booking);
    this.router.navigate(['registraions']);
  }
  acceptBooking() {
    this.httpService.acceptBooking(this.booking.id).subscribe();
    this.router.navigate(['registrations']);
  }
  declineBooking(){
    this.httpService.declineBooking(this.booking.id).subscribe();
    this.router.navigate(['registrations']);
  }

}

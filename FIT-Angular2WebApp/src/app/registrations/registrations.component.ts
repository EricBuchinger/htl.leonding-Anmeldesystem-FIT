import {Component, OnChanges, OnInit} from '@angular/core';
import {BookingHttpService} from "../data-service/all_bookings/all_booking-service.component";
import {Booking} from "../models/booking.model";
import {Contact} from "../models/contact.model";
import {isBoolean} from "util";
import {modalConfigDefaults} from "ng2-bootstrap";
import {timeout} from "rxjs/operator/timeout";
import {delay} from "rxjs/operator/delay";

@Component({
  selector: 'app-registrations',
  templateUrl: './registrations.component.html',
  styleUrls: ['./registrations.component.css']
})
  export class RegistrationsComponent {
  private bookings: Booking[];
  deleted: boolean;

  constructor(private httpService: BookingHttpService) {
    this.bookings = [];
    this.getBookings();
  }

  sucessfullDeleted() {
    return this.deleted;
  }


  deleteBooking(bookingId: number) {
    this.httpService.deleteBooking(bookingId).subscribe(() => {
      this.getBookings();
      this.deleted = true;
      setTimeout(() => {
        this.deleted = false;
      }, 1500)
    });

  }

  getBookings() {
    this.httpService.getAllRegistrations().subscribe(res => this.bookings = res);
  }



  sortById() {
    this.bookings.sort((a, b) => {
      if (a.id > b.id) {
        return 1;
      }
      else if (a.id < b.id) {
        return -1
      }
      else {
        return 0;
      }
    })
  }
  sortByCompanyName() {
    this.bookings.sort((a, b) => a.company.name.localeCompare(b.company.name));
  }
  sortbyArea(){
    this.bookings.sort((a, b) => {
      if (a.location.number > b.location.number) {
        return 1;
      }
      else if (a.location.number < b.location.number) {
        return -1
      }
      else {
        return 0;
      }
    })
  }
  sortByEmail(){
    this.bookings.sort((a, b) => a.company.email.localeCompare(b.company.email));
  }
}


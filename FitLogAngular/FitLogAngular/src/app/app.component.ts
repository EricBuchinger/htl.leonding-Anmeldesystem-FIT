import {Component, OnInit} from '@angular/core';
import {MdSidenav, MdToolbar, MdInputContainer, MdRadioGroup, MdRadioButton} from '@angular/material';
import 'hammerjs';
import { Booking } from "app/models/booking.model";
import { DetailAllocation } from "app/models/detail-allocation.model";
import { HttpService } from "app/services/http.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  tagList = ['WLAN', 'Strom','keine Tische','keine Sessel'];
  sponsorList=['Standard Parket 200€','Sponsoren Parket 400€','Presentation Parket 600€'];
  whatList=['Ferialjobs/Praktika','Diplomarbeiten'];
  subjectList=['Informatik/Medientechnik','Elektronik','Biomedizin'];
  agbList=['Ich gestatte hiermit, dass die erfassten Daten für die Erstellung einer gedruckten FIT Broschüre verwendet werden dürfen'];

  newBooking: Booking;
  austrianLocationDetail: DetailAllocation;
  otherLocationDetail: DetailAllocation;
  summerJobDetail: DetailAllocation;
  theisiWorkDetail : DetailAllocation;
  subInfoDetail: DetailAllocation;
  subElectricDetail: DetailAllocation;
  subBioMedDetail:DetailAllocation;

  public constructor(private httpService: HttpService) {
    this.newBooking = new Booking();
  
    this.austrianLocationDetail = new DetailAllocation();
    this.otherLocationDetail = new DetailAllocation();
    this.summerJobDetail = new DetailAllocation();
    this.theisiWorkDetail = new DetailAllocation();
    this.subInfoDetail = new DetailAllocation();
    this.subElectricDetail = new DetailAllocation();
    this.subBioMedDetail = new DetailAllocation();

    this.austrianLocationDetail.bokking = this.newBooking;
    this.otherLocationDetail.bokking = this.newBooking;
    this.summerJobDetail.bokking = this.newBooking;
  }

  public persistData(){
    console.log("HUSDASDASDASDASDAS");
      this.httpService.createBooking(this.newBooking).subscribe();
  }
  ngOnInit() {

  }
}

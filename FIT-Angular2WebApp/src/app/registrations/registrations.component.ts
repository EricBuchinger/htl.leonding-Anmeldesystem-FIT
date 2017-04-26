import { Component } from '@angular/core';
import {AppServiceComponent} from "../data-service/all_bookings/all_booking-service.component";
import {Company} from "../models/company.model";
import {Observable} from "rxjs";

@Component({
  selector: 'app-registrations',
  templateUrl: './registrations.component.html',
  styleUrls: ['./registrations.component.css']
})
export class RegistrationsComponent {
  companies:Observable<Company[]>;
  appservice:AppServiceComponent;

  constructor(){
    this.companies = this.appservice.getAllRegistrations();
  }

}

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './root/app.component';
import { RegistrationsComponent } from './registrations/registrations.component';
import {BookingHttpService} from "./data-service/all_bookings/all_booking-service.component";

@NgModule({
  declarations: [
    AppComponent,
    RegistrationsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [BookingHttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }

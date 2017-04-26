import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './root/app.component';
import { RegistrationsComponent } from './registrations/registrations.component';
import { AppServiceComponent } from './data-service/all_bookings/all_booking-service.component';

@NgModule({
  declarations: [
    AppComponent,
    RegistrationsComponent,
    AppServiceComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

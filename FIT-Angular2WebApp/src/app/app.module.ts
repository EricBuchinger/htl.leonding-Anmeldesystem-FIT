import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './root/app.component';
import { RegistrationsComponent } from './registrations/registrations.component';
import {BookingHttpService} from "./data-service/all_bookings/all_booking-service.component";
import {AlertModule} from 'ng2-bootstrap';
import { ButtonStyleDirective } from './directives/button-style.directive';
import { EditRegistrationComponent } from './registrations/edit-registration/edit-registration.component';
import {routes} from "./app.routing";
import { ToolbarComponent } from "app/toolbar/toolbar.component";

@NgModule({
  declarations: [
    AppComponent,
    RegistrationsComponent,
    ButtonStyleDirective,
    EditRegistrationComponent,
    ToolbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AlertModule.forRoot(),
    routes
  ],
  providers: [BookingHttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }

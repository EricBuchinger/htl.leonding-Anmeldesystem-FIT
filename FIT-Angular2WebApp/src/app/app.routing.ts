import {RouterModule, Routes} from "@angular/router";
import {RegistrationsComponent} from "./registrations/registrations.component";
import {EditRegistrationComponent} from "./registrations/edit-registration/edit-registration.component";
const APP_ROUTES:Routes = [
  {path:'registrations', component:RegistrationsComponent},
  {path:'registrations/:id', component:EditRegistrationComponent}
];

export const routes = RouterModule.forRoot(APP_ROUTES);

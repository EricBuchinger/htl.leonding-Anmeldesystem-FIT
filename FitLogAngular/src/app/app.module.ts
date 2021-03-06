import {BrowserModule} from '@angular/platform-browser';
import {NgModule, CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {HttpModule} from '@angular/http';
import {HttpService} from './services/http.service';

import {AppComponent} from './app.component';
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {
  MdButtonModule,
  MdCheckboxModule,
  MdInputModule,
  MdTabsModule,
  MdCommonModule,
  MdCoreModule,
  MdToolbarModule,
  MdIconRegistry,
  MdSidenavModule,
  MdRadioModule,
  MdListModule
} from '@angular/material';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    BrowserAnimationsModule,
    MdButtonModule,
    MdCheckboxModule,
    MdInputModule,
    MdTabsModule,
    MdCommonModule,
    MdCoreModule,
    MdToolbarModule,
    MdSidenavModule,
    MdRadioModule,
    MdListModule
  ],
  providers: [HttpService, MdIconRegistry],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent]
})
export class AppModule {
}

import {Component, OnInit} from '@angular/core';
import {HttpService} from './services/http.service';
import {Company} from './entities/company';
import {MdSidenav, MdToolbar, MdInputContainer, MdRadioGroup, MdRadioButton} from '@angular/material';
import 'hammerjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  private companies: Company[];
  actCompany: Company = new Company(0, null, null, null, null, null, null, null, null, null, null, null, null);
  tagList = ['Anmeldung für nächsten Fit', 'Other'];

  constructor(private _httpService: HttpService) {

  }

  ngOnInit() {
    this._httpService.getAllCompanies().subscribe(res => this.companies = res.json());
  }

  init(): any {
    return
  }

  selectCompany(comp: Company) {
    Object.assign(this.actCompany, comp);
  }

  createCompany(name: MdInputContainer,
                email: MdInputContainer,
                shortdesc: MdInputContainer,
                address: MdInputContainer,
                phonenumber: MdInputContainer,
                homepage: MdInputContainer,
                companysign: MdInputContainer,
                subjectArea: MdInputContainer,
                tag: MdRadioGroup) {

    let tagValue: string = '';

    console.log(tag.value);

    let temp: Company = new Company(0,
      name._mdInputChild.value,
      shortdesc._mdInputChild.value,
      null,
      1,
      null,
      1,
      phonenumber._mdInputChild.value,
      email._mdInputChild.value,
      homepage._mdInputChild.value,
      "EQAAAfIoxlUqQEgB",
      subjectArea._mdInputChild.value,
      tag.value
    );
    console.log("name: " + name._mdInputChild.value, "tagValue " + tag.value);
    // let temp : Company = new Company(2000,"first", "Best Description ever", null, 1, null, 1, "12309089891230", "te.stest@gmail.com", "www.testfirma.com", "EQAAAfIoxlUqQEgB", "Informatik");
    this._httpService.createCompany(temp).subscribe(data => {
      this._httpService.getAllCompanies().subscribe(res => this.companies = res.json());
    });
  }

  updateCompany(name: MdInputContainer, email: MdInputContainer, shortdesc: MdInputContainer, address: MdInputContainer, phonenumber: MdInputContainer, homepage: MdInputContainer, companysign: MdInputContainer, subjectArea: MdInputContainer, tag: MdRadioButton) {
    // let company : Company = new Company(this.actCompany.id,name._mdInputChild.value, shortdesc._mdInputChild.value, null, null, null, null, phonenumber._mdInputChild.value, email._mdInputChild.value, homepage._mdInputChild.value, this.actCompany.companySign, subjectArea._mdInputChild.value);
    // let company : Company = new Company(this.actCompany.id,"TestFirma Test", "Best Description ever", null, 1, null, 1, "12309089891230", "te.stest@gmail.com", "www.testfirma.com", "EQAAAfIoxlUqQEgB", "Informatik");

    this._httpService.updateCompany(this.actCompany).subscribe(data => {
      this.actCompany = data.json();
      this._httpService.getAllCompanies().subscribe(res => this.companies = res.json());
    });
  }

  deleteCompany(id: number) {
    this._httpService.deleteCompany(id).subscribe(res => {
      this._httpService.getAllCompanies().subscribe(res => this.companies = res.json());
    });
  }
}

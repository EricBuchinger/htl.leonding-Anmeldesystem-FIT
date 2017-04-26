import {Component, Injectable} from '@angular/core';
import {Http, Response} from "@angular/http";
import {Company} from '../models/company.model';
import {Observable} from "rxjs";


@Component({
  selector: 'app-app-service',
  templateUrl: './app-service.component.html',
  styleUrls: ['./app-service.component.css']
})

@Injectable()
export class AppServiceComponent  {
  API_URL: string = "";
  constructor (private http: Http) {
  }

  getAllRegistrations(){
     return this.http.get(this.API_URL+"companies")
       .map((response: Response)=>response.json() as Company[])
       .catch(err=>{console.log(err);return Observable.of<Company[]>([])});

    }

}

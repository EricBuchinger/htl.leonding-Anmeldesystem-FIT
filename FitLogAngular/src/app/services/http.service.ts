import { Injectable } from '@angular/core';
import { Http, Headers, Response, BaseRequestOptions, RequestOptions } from '@angular/http';
import { Observable } from "rxjs";

@Injectable()
export class HttpService {

  constructor(private http: Http) { }

  getAllCompanies(): Observable<any> {
    var headers2: Headers = new Headers();
    headers2.append('Content-Type', 'application/json');
    return this.http.get("http://localhost:5000/api/company", { headers: headers2 });
  }

  createCompany(company: Object): Observable<any> {
    var headers2: Headers = new Headers();
    headers2.append('Content-Type', 'application/json');
    console.log("create: " + company);
    return this.http.post("http://localhost:5000/api/company", company, { headers: headers2 });
  }

  updateCompany(company: Object): Observable<any> {
    var headers2: Headers = new Headers();
    headers2.append('Content-Type', 'application/json');
    console.log(company);
    return this.http.put("http://localhost:5000/api/company", company, { headers: headers2 });
  }

  deleteCompany(id: number): Observable<any> {
    var headers2: Headers = new Headers();
    headers2.append('Content-Type', 'application/json');
    return this.http.delete("http://localhost:5000/api/company/" + id, { headers: headers2 });
  }
}

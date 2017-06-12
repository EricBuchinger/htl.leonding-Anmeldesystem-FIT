import { Injectable } from '@angular/core';
import { Http, Headers, Response, BaseRequestOptions, RequestOptions } from '@angular/http';
import { Observable } from "rxjs";
import { Booking } from "app/models/booking.model";

@Injectable()
export class HttpService {

  constructor(private http: Http) { }

  createBooking(booking: Booking): Observable<Response> {
    let headers: Headers = new Headers();
    headers.append('Content-Type', 'application/json');
    return this.http.post("http://localhost:5000/api/fit/createNewBooking", booking, {headers: headers});
  }
}

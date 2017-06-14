import {Injectable} from '@angular/core';
import {Http, Headers, Response} from "@angular/http";
import {Observable} from "rxjs";
import {Booking} from "../../models/booking.model";

@Injectable()
export class BookingHttpService{
  API_URL: string = "http://localhost:5000/api/fit/";

  constructor (private http: Http) { }

  getAllRegistrations() :Observable<Booking[]>{
    return this.http.get(this.API_URL+"getallbooking") .map((response:Response)=>response.json() as Booking[])
      .catch(err=>{console.log(err);
      return Observable.of<Booking[]>([])});
  }
  deleteBooking(bookingId:number){
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    return this.http.delete(this.API_URL+"booking/"+bookingId,{headers: headers});
  }
  acceptBooking(bookingId:number){
    return this.http.get(this.API_URL+"updateBookingStatusAccept/"+bookingId);
  }
  getBookingById(bookingId:number){
    return this.http.get(this.API_URL+"booking/"+bookingId).map((response:Response)=> response.json() as Booking)
      .catch(err=>{console.log(err);
        return Observable.of<Booking>()});
  }
  updateBooking(booking:Booking){
    let headers = new Headers({ 'Content-Type': 'application/json' });
    return this.http.put(this.API_URL+"booking/"+booking.id, booking, {headers: headers})
      .map((res:Response) => res.json());

  }
  declineBooking(bookingId:number){
    return this.http.get(this.API_URL+"updateBookingStatusDeclined/"+bookingId);
  }

}

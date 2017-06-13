import {Adress} from "./adress.model";
import {Contact} from "./contact.model";
import {EntityObject} from "./entityObject";
export class Company extends EntityObject{

   constructor(public id:number,
               public timestamp:string,
               public name:string,
               public shortDescription:string,
               public address:Adress,
               public contact:Contact,
               public phoneNumber:string,
               public email:string,
               public homepage:string,
               public companySign:string,
               public subjectAreas:string){

     super(id,timestamp);
   }
}

import {Adress} from "./adress.model";
import {Contact} from "./contact.model";
import {EntityObject} from "./entityObject";
export class Company extends EntityObject{
   name: string ="";
   shortDescription: string="";
   adress: Adress;
   contact: Contact;
   phoneNumber: string="";
   email: string="";
   homepage: string="";
   companySign: any;
   subjectAreas: string="";
   comment: string="";

   public constructor() {
       super();
       this.adress = new Adress();
       this.contact = new Contact();
   }
}

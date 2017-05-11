import {Adress} from "./adress.model";
import {Contact} from "./contact.model";
import {EntityObject} from "./entityObject";
export interface Company extends EntityObject{
   name: string;
   shortDescription: string;
   address: Adress;
   contact: Contact;
   phoneNumber: string;
   email: string;
   homepage: string;
   companySign: string;
   subjectAreas: string;
}

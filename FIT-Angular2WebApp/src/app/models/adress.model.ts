import {EntityObject} from "./entityObject";
export interface Adress extends EntityObject{
  city:string;
  postalCode:string;
  street:string;
  number:string;
}

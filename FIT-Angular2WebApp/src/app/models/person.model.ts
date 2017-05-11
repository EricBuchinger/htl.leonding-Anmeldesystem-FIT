
import {EntityObject} from "./entityObject";
export interface Person extends EntityObject{
  firstName:string;
  lastName:string;
  email:string;
  picture:string;
  phoneNumber:string;
}

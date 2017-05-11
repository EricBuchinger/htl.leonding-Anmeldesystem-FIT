
import {EntityObject} from "./entityObject";
export interface Presentation extends EntityObject{
  roomNumber:string;
  title:string;
  description:string;
  isAccepted:boolean;
}

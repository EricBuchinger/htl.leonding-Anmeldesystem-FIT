import {EntityObject} from "./entityObject";
import {Event} from "./event.model";
export interface Area extends EntityObject{
  designation:string;
  graphic:string;
  event:Event;
}

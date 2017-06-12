
import {EntityObject} from "./entityObject";
import {Location} from "./location.model";
export class Category extends EntityObject{
  name:string;
  price:number;
  description:string;
  location:Location = new Location();
}

import {EntityObject} from "./entityObject";
import {Event} from "./event.model";
import {Company} from "./company.model";
import {Location} from "./location.model";
import {Presentation} from "./presentation.model";
import {Category} from "./category.model";
export interface Booking extends EntityObject{

  event:Event;
  company:Company;
  location:Location;
  presentation:Presentation;
  category:Category;
  isAccepted:boolean;


}



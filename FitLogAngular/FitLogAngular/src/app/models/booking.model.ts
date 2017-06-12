
import {EntityObject} from "./entityObject";
import {Event} from "./event.model";
import {Company} from "./company.model";
import {Location} from "./location.model";
import {Presentation} from "./presentation.model";
import {Category} from "./category.model";
export class Booking extends EntityObject{

  event:Event;
  company:Company;
  location:Location;
  presentation:Presentation;
  category:Category;
  isAccepted:boolean;

  public constructor() {
    super();
    this.event = new Event();
    this.location = new Location();
    this.presentation = new Presentation();
    this.category = new Category();
    this.company = new Company();
    this.isAccepted = false;
  }
}



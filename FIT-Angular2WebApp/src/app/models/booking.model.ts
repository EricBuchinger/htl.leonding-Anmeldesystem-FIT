
import {EntityObject} from "./entityObject";
import {Event} from "./event.model";
import {Company} from "./company.model";
import {Location} from "./location.model";
import {Presentation} from "./presentation.model";
import {Category} from "./category.model";
export class Booking extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public event:Event,
              public company:Company,
              public location:Location,
              public presentation:Presentation,
              public category:Category,
              public isAccepted:boolean){

    super(id,timestamp);
  }

}



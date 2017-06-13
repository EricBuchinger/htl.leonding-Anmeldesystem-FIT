
import {EntityObject} from "./entityObject";
import {Location} from "./location.model";
export class Category extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public name:string,
              public price:number,
              public description:string,
              public location:Location){

    super(id,timestamp)
  }
}

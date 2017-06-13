import {EntityObject} from "./entityObject";
import {Event} from "./event.model";
export class Area extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public designation:string,
              public graphic:string,
              public event:Event){
    super(id,timestamp);
  }
}

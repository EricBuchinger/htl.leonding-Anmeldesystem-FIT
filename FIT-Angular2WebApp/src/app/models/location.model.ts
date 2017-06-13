
import {EntityObject} from "./entityObject";
import {Area} from "./area.model";
export class Location extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public number:number,
              public area:Area,
              public xCoordinate:number,
              public yCoordinate:number){
    super(id,timestamp);
  }
}

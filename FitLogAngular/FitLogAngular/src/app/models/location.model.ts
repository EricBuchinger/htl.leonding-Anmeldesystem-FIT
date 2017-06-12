
import {EntityObject} from "./entityObject";
import {Area} from "./area.model";
export class Location extends EntityObject{

  number:number;
  area:Area = new Area();
  xCoordinate:number;
  yCoordinate:number;
}

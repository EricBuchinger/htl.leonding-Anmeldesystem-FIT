
import {EntityObject} from "./entityObject";
import {Area} from "./area.model";
export interface Location extends EntityObject{

  number:number;
  area:Area;
  xCoordinate:number;
  yCoordinate:number;
}

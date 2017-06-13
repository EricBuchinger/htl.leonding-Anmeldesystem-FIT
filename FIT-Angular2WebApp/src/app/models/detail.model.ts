import {EntityObject} from "./entityObject";
export class Detail extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public description:string){
    super(id,timestamp);
  }
}

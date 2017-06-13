
import {EntityObject} from "./entityObject";
export class Presentation extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public roomNumber:string,
              public title:string,
              public description:string,
              public isAccepted:boolean){
    super(id,timestamp);
  }
}

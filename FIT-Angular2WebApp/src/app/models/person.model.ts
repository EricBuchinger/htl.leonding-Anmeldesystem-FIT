
import {EntityObject} from "./entityObject";
export class Person extends EntityObject{


  constructor(public id:number,
              public timestamp:string,
              public firstName:string,
              public lastName:string,
              public email:string,
              public picture:string,
              public phoneNumber:string){
    super(id,timestamp);
  }
}

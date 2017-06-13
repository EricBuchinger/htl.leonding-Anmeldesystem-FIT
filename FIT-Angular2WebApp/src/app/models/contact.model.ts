
import {Person} from "./person.model";
import {EntityObject} from "./entityObject";
export class Contact extends EntityObject{

  constructor(public id:number,
              public timestamp:string,
              public person:Person){
    super(id,timestamp);
  }
}

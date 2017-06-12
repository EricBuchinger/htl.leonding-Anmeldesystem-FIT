
import {Person} from "./person.model";
import {EntityObject} from "./entityObject";
export class Contact extends EntityObject{
  person:Person;

  public constructor(){
    super();
    this.person = new Person();
  }
}

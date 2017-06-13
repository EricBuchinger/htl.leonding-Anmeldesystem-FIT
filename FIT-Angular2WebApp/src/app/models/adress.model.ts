import {EntityObject} from "./entityObject";
export class Adress extends EntityObject{


  constructor(public id,
              public timestamp,
              public city:string,
              public postalCode:string,
              public street:string,
              public number:string){
    super(id,timestamp);
}
}

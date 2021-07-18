import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';


@Injectable()
export class ProduceService {
  constructor(private http: HttpClient) { }

  getProduce() {
    return this.http.get('/api/produce')
      .pipe(
        map((res: Response) => res.json())
    )
  }
}

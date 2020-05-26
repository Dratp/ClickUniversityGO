import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Question, Answer } from './interfaces/qandA';

@Injectable()
export class QandADataService {
  constructor(private http: HttpClient) {

  }
  async addNewQuestion(question: Partial<Question>) {

    return this.http.post<number>('/api/QandA', question).toPromise();
  }
}

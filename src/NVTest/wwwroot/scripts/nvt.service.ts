import {Injectable} from 'angular2/core';
import {QUESTIONS} from './mock-questions';
@Injectable()
export class NVTService {
    getQuestions() {
        return QUESTIONS;
    }
}
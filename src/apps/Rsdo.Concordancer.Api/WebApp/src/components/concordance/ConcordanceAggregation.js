import { useState } from 'react';

import ConcordanceAggregationItem from './ConcordanceAggregationItem';

import styles from './ConcordanceAggregation.module.scss';
import chevronDown from '../../assets/chevron-down.svg';
import chevronUp from '../../assets/chevron-up.svg'

const ConcordanceAggregation = (props) => {
    const expandable = props.items.length > 5;
    const [isExpanded, setIsExpanded] = useState(false);
    const items = expandable && !isExpanded ? props.items.slice(0, 5) : props.items;

    const expandHandler = () => {
        setIsExpanded((prevState) => !prevState);
    };

    const headerEl = expandable ? <h2 onClick={expandHandler}>{props.title} <img className='float-end' src={isExpanded ? chevronUp : chevronDown} alt={isExpanded ? 'Collapse' : 'Expand'} /></h2> : <h2>{props.title}</h2>

    return (
        <div className={styles.aggregation}>
            {headerEl}
            <ul>
                {items.map(x => <ConcordanceAggregationItem key={x.key} filterKey={x.key} title={x.title} count={x.count} />)}
            </ul>
        </div>
    );
};

export default ConcordanceAggregation;